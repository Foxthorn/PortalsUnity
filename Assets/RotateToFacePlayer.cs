using UnityEngine;

public class RotateToFacePlayer : MonoBehaviour
{
    public Transform player;
    public Transform world;
    public Transform renderPlane;
    public Renderer renderPlaneGO;

    public Material CameraMatA;
    public Material CameraMatB;

    private bool playerIsBehind = false;

    // Update is called once per frame
    private void Update()
    {
        Vector3 portalToPlayer = player.position - transform.position;
        float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

        if (dotProduct < 0f)
        {
            renderPlane.Rotate(Vector3.back, 180);
            if (renderPlaneGO.material.name == "CameraMat_B (Instance)")
            {
                renderPlaneGO.material = CameraMatA;
            }
            else if (renderPlaneGO.material.name == "CameraMat_A (Instance)")
            {
                renderPlaneGO.material = CameraMatB;
            }
        }
    }
}