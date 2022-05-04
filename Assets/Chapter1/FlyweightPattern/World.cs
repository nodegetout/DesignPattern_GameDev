using UnityEngine;

namespace Chapter1.FlyweightPattern
{
    public class World : MonoBehaviour
    {
        public int worldWidth = 5;
        public int worldHeight = 5;
        public GameObject hillPrefab;
        public GameObject grassPrefab;
        public GameObject waterPrefab;

        private VirtualTerrain[,] m_Terrains;

        // Start is called before the first frame update
        void Start()
        {
            m_Terrains = new VirtualTerrain[worldWidth, worldHeight];
            CreateWorld();
        }
        
        void CreateWorld()
        {
            if (m_Terrains == null)
            {
                return;
            }

            for (int i = 0; i < worldWidth; i++)
            {
                for (int j = 0; j < worldHeight; j++)
                {
                    int value = Random.Range(0, 10);
                    if ( value == 2)
                    {
                        m_Terrains[i, j] = new VirtualTerrain(value, true, waterPrefab, transform);
                    }else if (value == 3)
                    {
                        m_Terrains[i, j] = new VirtualTerrain(value, false, hillPrefab, transform);
                    }
                    else
                    {
                        m_Terrains[i, j] = new VirtualTerrain(1, false, grassPrefab, transform);
                    }
                    
                    m_Terrains[i, j].SetTerrainPosition(i, j);
                }
            }
        }
    }

    public class VirtualTerrain
    {
        private int  m_MovementCost;
        private bool m_IsWater;
        private GameObject m_Prefab;

        public VirtualTerrain(int cost, bool isWater, GameObject prefab, Transform parent)
        {
            this.m_MovementCost = cost;
            this.m_IsWater = isWater;
            this.m_Prefab = GameObject.Instantiate(prefab, parent);
        }

        public void SetTerrainPosition(int x, int y)
        {
            m_Prefab.transform.position = new Vector3(x, 0, y);
        }
    }
}
