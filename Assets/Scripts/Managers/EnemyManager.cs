using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
	public int fib1, fib2, fibsum;
	public int MobCap = 5;


    void Start ()
    {
		fib1 = 0;
		fib2 = 1;
		fibsum = 1;
        InvokeRepeating ("Spawn", 10f, spawnTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		
		for (int i = 0; i < fibsum; i++) {
			Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		}

		if (fibsum < MobCap) {
			fibsum = fib1 + fib2;
			fib1 = fib2;
			fib2 = fibsum;
		}

    }
}
