using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class TextureScroller : MonoBehaviour
{
    public float scrollSpeed;
    private Material mat;
    private float uvFactor;

    private void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        float n = mat.GetTextureScale("_MainTex").y;
        float scale = transform.localScale.z;
        uvFactor = n / scale;
    }

    private void Update()
    {
        mat.mainTextureOffset = new Vector2(mat.mainTextureOffset.x, mat.mainTextureOffset.y + Time.deltaTime * scrollSpeed * uvFactor);
    }
}
