using Unity.Netcode;
using UnityEngine;
using TMPro;

public class PlayerNameDisplay : NetworkBehaviour
{
    [SerializeField] private TMP_Text nameText;

    public override void OnNetworkSpawn()
    {
        if (nameText == null)
        {
            Debug.LogError("Name Text is not assigned on PlayerNameDisplay");
            return;
        }

        nameText.text = "Player " + OwnerClientId;
    }

    private void LateUpdate()
    {
        if (nameText == null || Camera.main == null)
        {
            return;
        }

        nameText.transform.LookAt(Camera.main.transform);
        nameText.transform.Rotate(0, 180f, 0);
    }
}