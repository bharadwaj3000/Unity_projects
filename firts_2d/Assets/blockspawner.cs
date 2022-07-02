using UnityEngine;

public class blockspawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject blockprefab;

    public float timetospawn = 2f;
 
    // Update is called once per frame
    void Update(){
        if(Time.time >= timetospawn){
            spawner();
            timetospawn = Time.time + 1f;
        }
        
    }

    void spawner(){
        int random = Random.Range(0, spawnPoints.Length);
        for(int i=0;i<spawnPoints.Length;i++){
            if(i != random){
                Instantiate(blockprefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }

    
}
