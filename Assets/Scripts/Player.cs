using UnityEngine;
public class Player : MonoBehaviour
{
    public float upSpod = 5.0f;
    public Rigidbody2D rb;
    public string currentColor;
    public SpriteRenderer sr;
    public SpriteRenderer pellet;

    //color list
    public Color Bluu;
    public Color Yelll;
    public Color Purpp;
    public Color Ponkk;

    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * upSpod;
            //setting velocity instead of adding force, since the game wants an instant constant jump height
        }
        if (transform.position.y < -5)
        {
            rb.velocity = Vector2.up * upSpod;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.tag);
        if (col.tag == "Pellet")
        {
            currentColor = SetRandomColor();
            Destroy(col.gameObject);
        }
        else
        {
            if (currentColor != col.tag)
            {
                Death();
            }
            else
            {
                Debug.Log("GG");
            }
        }
    }

    string SetRandomColor()
    {
        string randomColor;

        string[] colors = { "Blu", "Yell", "Purp", "Ponk" };

        int idx = Random.Range(0, 3);

        randomColor = colors[idx];

        switch (idx)
        {
            case 0: sr.color = Bluu; break;
            case 1: sr.color = Yelll; break;
            case 2: sr.color = Purpp; break;
            case 3: sr.color = Ponkk; break;
        }

        return randomColor;
    }
    void Death()
    {
        Debug.Log("You Suck");
        GetComponent<ParticleSystem>().Play();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Player>().enabled = false;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }
}
