using Unity.Netcode;
using UnityEngine;

public class CameraFollow : NetworkBehaviour
{
    private Camera m_camera;
    private Vector3 m_offsetFromPlayer;

    public override void OnNetworkSpawn()
    {
        if (!IsOwner)
            return;

        m_camera = Camera.main;

        if (m_camera == null)
            return;

        m_offsetFromPlayer = transform.position - m_camera.transform.position;
    }

    private void LateUpdate()
    {
        if (!IsOwner || m_camera == null)
            return;

        m_camera.transform.position = transform.position - m_offsetFromPlayer;
    }
}