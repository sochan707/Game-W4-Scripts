using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] private Color newColor = Color.red;
    [SerializeField] private Renderer rend;
    private Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
        }
    }

    void OnMouseDown()
    {
        rend.material.color = Random.ColorHSV();
           
    }
}
