using UnityEngine;
using System.Collections.Generic;

namespace AG3959
{
    public class CylinderSpawning : MonoBehaviour
    {
        public GameObject cylinderPrefab;         
        public Transform spawnPoint;             
        public float spawnInterval = 2f;          

        void Start()
        {
            InvokeRepeating(nameof(SpawnCylinder), 0f, spawnInterval);
        }

        void SpawnCylinder()
        {
            GameObject cylinder = Instantiate(cylinderPrefab, spawnPoint.position, Quaternion.identity);
            cylinder.tag = "Cylinder"; 
        }
    }
}