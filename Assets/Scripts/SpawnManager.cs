using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    //Variables

        //Publicas
        public GameObject obstaclePrefab;
        
        //Privadas
        private Vector3 spawnPos = new Vector3(0, 0, 30);
        private float RandomY;
        private float startTime = 0.5f;
        private float cicleTime = 5f;
        private float randomNumber = 11f;

    // Start is called before the first frame update
    void Start()
    {
        //Posición inicial de juego
        transform.position = new Vector3(0, 0, 0);

        //Generador de Obstaculos
        InvokeRepeating("SpawnObstacle", startTime, cicleTime);
    }

    //Funcion de Instanciación, aleatoriza la generación de los obstaculos
    public void SpawnObstacle()
    {
        RandomY = Random.Range(-randomNumber, randomNumber);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        spawnPos = new Vector3(0, RandomY, spawnPos.z + 50);
    }


   
}
