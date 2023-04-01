using UnityEngine;
public class Bird : MonoBehaviour
{
    [SerializeField] float jumpAmount;
    [SerializeField] GameManager gameManager;
    new Rigidbody2D rigidbody2D;
    private void Start() {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
             //jump   
            Jump();
        }
    }
    
    #region private methods
    void Jump()
    {
        rigidbody2D.velocity = Vector2.up * jumpAmount;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        gameManager.GameOver();
    }
    #endregion
}
