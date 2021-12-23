using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{
    public Rigidbody _player;
    private Vector3 _previousMousePosition;
    public float Sensetivity = 1f;
    [Range(0, 4)]
    private float _speed;
    public int Eat;

    public Eat eat;
   


    public UnityEvent OnEat;

    private void Start()
    {
        _speed = 1f;
    }
    private void Awake()
    {
        _player = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            _player.AddForce(delta.x * Sensetivity, 0, 0);
            
        }
        _previousMousePosition = Input.mousePosition;
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);

            

            if (OnEat != null)
            {
                OnEat.Invoke();
            }
        }
        if (collision.gameObject.tag == "Cub")
        {
            
            SceneManager.LoadScene(2);
        }




    }
   










}
