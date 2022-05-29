using UnityEngine;

public class ChangeLocations : MonoBehaviour
{
    public GameObject activeStreet;

    public void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Player"))
       {
           activeStreet.SetActive(true);
       }
    }

    public void OnTriggerExit2D(Collider2D other)
    {    
       if (other.CompareTag("Player"))
       {
           activeStreet.SetActive(false);
       }
    }

   //public int levelToLoad;

   // private void Start()
   // {
   //     anim = GetComponent<Animator>();
   // }
   //
   // public void FadeToLevel()
   // {
   //     anim.SetTrigger("fade");
   // }

   // public void ChangeLevel()
   // {
   //     SceneManager.LoadScene(levelToLoad);
   // }

    public static void ExitGame()
    {
        Debug.Log("Game over");
        Application.Quit();
    }
}
