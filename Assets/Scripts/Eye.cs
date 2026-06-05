using UnityEngine;

public class Eye : MonoBehaviour
{
    [SerializeField] private Sprite eye_up;
    [SerializeField] private Sprite eye_down;
    [SerializeField] private Sprite eye_left;
    [SerializeField] private Sprite eye_right;

    private SpriteRenderer _sr;

    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    public void ChangeEye(Vector2 direction)
    {
        if(direction == Vector2.up)_sr.sprite = eye_up;
        if(direction == Vector2.down) _sr.sprite = eye_down;
        if(direction == Vector2.left) _sr.sprite = eye_left;
        if(direction == Vector2.right) _sr.sprite = eye_right;
    }
}
