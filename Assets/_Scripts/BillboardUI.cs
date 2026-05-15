using UnityEngine;

public class BillboardUI : MonoBehaviour
{
    private Transform m_cameraTransform;

    private void Awake()
    {
        m_cameraTransform = Camera.main.transform;
    }

    private void LateUpdate()
    {
        Vector3 direction = transform.position - m_cameraTransform.position;
        direction.y = 0;
        if(direction.sqrMagnitude > 0.001f)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}
