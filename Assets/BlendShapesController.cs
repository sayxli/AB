using UnityEngine;

public class BlendShapesController : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer;
    public float smileAmount = 0.0f;

    void Start()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    void Update()
    {
        skinnedMeshRenderer.SetBlendShapeWeight(0, smileAmount);
    }
}

