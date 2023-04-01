using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    float spawnCoolDown = 1.5f;
    float timer=0;
    [SerializeField] float height;
    [SerializeField] GameObject pipe;
    private void Update() {
        SpawnPipe();
    }

    #region private methods
    void SpawnPipe()
    {
        if(timer>spawnCoolDown)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position=transform.position+new Vector3(0,Random.Range(-height,height),0);
            Destroy(newPipe,6);
            timer=0;
        }
        timer+=Time.deltaTime;
    }
    #endregion
}
