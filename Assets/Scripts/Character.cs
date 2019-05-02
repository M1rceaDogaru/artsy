using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    [Range(0f, 1f)]
    public float AnimationSpeed = 0.2f;

    private Rigidbody2D _body;
    private Animation _runAnimation;

    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
        _runAnimation = GetComponentInChildren<Animation>();
        _runAnimation["Run"].speed = AnimationSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Flip();
        }
    }

    void Flip()
    {
        transform.localScale = new Vector3(transform.localScale.x, -transform.localScale.y, transform.localScale.z);
        _body.gravityScale = -_body.gravityScale;
    }
}
