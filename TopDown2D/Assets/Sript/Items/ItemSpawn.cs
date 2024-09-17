using UnityEngine;


public class ItemSpawn : MonoBehaviour
{
    
    public GameObject toSpawn;

    
    public float toSpwan;

    
    private float currentTimeToSpawn;

    // Start is called before the first frame update

    
    internal void Start()
    {
    }

    // Update is called once per frame

   
    internal void Update()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;

        }
        else
        {
            spawnObject();
            currentTimeToSpawn = toSpwan;
        }
    }

   
    public void spawnObject()
    {
        Instantiate(toSpawn, transform.position, Quaternion.identity);
        toSpawn.tag = "Item";
    }
}
