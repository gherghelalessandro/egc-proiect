using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    // Start is called before the first frame update
    public string text = "main hub";
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var player = other.gameObject.GetComponent<Movement>();
            float timp = 0.01f;
            player.sound_death.Play();
            while (timp < 40000)
            {
                timp += timp * Time.deltaTime;
            }

            SceneManager.LoadScene(text);
        }
    }
}
