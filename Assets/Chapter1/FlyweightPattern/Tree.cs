using UnityEngine;
using Random = UnityEngine.Random;

namespace Chapter1.FlyweightPattern
{
    public class Tree : MonoBehaviour
    {
        public TreeModel treeModel;

        private delegate GameObject CreateTreeHandler();
        private event CreateTreeHandler OnTreeCreate;
        
        void Start()
        {
            OnTreeCreate = treeModel.CreateRandomTreeGameObject;
        }
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                var go = OnTreeCreate?.Invoke();
                if (go != null)
                {
                    go.transform.position = Random.onUnitSphere * 15f;
                    go.transform.rotation = Quaternion.FromToRotation(Vector3.zero, go.transform.position);
                }
            }
        }
    }
}