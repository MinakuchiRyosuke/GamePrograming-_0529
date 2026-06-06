using UnityEngine;

public class Dots : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            GameManager.instance.CheckDots();
        }
    }
}
