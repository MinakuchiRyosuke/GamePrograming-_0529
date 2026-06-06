using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {  get; private set; }
    [SerializeField] private Transform dots;

    private void Awake()
    {
        instance = this;
    }

    public void CheckDots()
    {
        foreach(Transform t in dots)
        {
            if(t.gameObject.activeSelf)
            {
                return;
            }
        }
        Debug.Log("CLEAR");
    }

    public void GameOver()
    {
        Debug.Log("GAMEOVER");
    }
}
