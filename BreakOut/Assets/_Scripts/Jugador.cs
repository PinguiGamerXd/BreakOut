using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int LimiteX = 23;
    [SerializeField] public float VelocidadPaddle = 15f;

    Transform transform;
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform= this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //mousePos2D = Input.mousePosition;
        //mousePos2D.z = -Camera.main.transform.position.z;
        //mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        //Vector3 pos = this.transform.position;

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(Vector3.down * VelocidadPaddle * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector3.up * VelocidadPaddle * Time.deltaTime);
        //}

        transform.Translate(Input.GetAxis("Horizontal")*Vector3.down * VelocidadPaddle * Time.deltaTime);

        Vector3 pos = transform.position;


        //pos.x = mousePos2D.x;
        if (pos.x < -LimiteX)
        {
            pos.x = -LimiteX;
        }
        else if (pos.x > LimiteX)
        {
            pos.x = LimiteX;
        }

        transform.position = pos;
    }
}
