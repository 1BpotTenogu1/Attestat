using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Snake snake)) return;
        {
            SceneManager.LoadScene(5);
        }
        
    }
}
