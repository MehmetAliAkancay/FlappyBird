using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float moveSpeed=1;
    private void Update() {
        Move();
    }
    #region private methods
    void Move(){
        transform.position+=Vector3.left*moveSpeed*Time.deltaTime;
    }
    #endregion
}
