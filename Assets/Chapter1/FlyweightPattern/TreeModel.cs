using UnityEngine;

namespace Chapter1.FlyweightPattern
{
    [CreateAssetMenu(menuName = "DesignPattern/Flyweight/TreeModelAsset", fileName = "treeModelAsset", order = 91)]
    public class TreeModel : ScriptableObject
    {
        public Mesh mesh;
        public Material   barkMaterial;
        public Material[] leafMaterial;

        public GameObject CreateRandomTreeGameObject()
        {
            if (mesh == null || barkMaterial == null || leafMaterial == null || leafMaterial.Length <=0)
            {
                return null;
            }

            GameObject go = new GameObject("tree");
            var meshFilter   = go.AddComponent<MeshFilter>();
            var meshRenderer = go.AddComponent<MeshRenderer>();
            meshFilter.mesh = this.mesh;
            meshRenderer.materials = new Material[2];
            meshRenderer.materials[0] = barkMaterial;
            meshRenderer.materials[0].CopyPropertiesFromMaterial(barkMaterial);
            int index = Random.Range(0, leafMaterial.Length);
            meshRenderer.materials[1].CopyPropertiesFromMaterial(leafMaterial[index]);

            return go;
        }
    }
}