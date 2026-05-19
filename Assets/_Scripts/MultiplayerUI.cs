using System;
using UnityEngine;
using UnityEngine.UIElements;


public class MultiplayerUI : MonoBehaviour
{
    [SerializeField]
    private UIDocument m_uiDocument;
    [SerializeField]
    private Button m_hostButton, m_clientButton, m_clientDisconnect;

    public event Action OnStartHost, OnStartClient, OnDisconnectClient;
    private void Awake()
    {
        m_hostButton = m_uiDocument.rootVisualElement.Q<Button>("ButtonHost");
        m_clientButton = m_uiDocument.rootVisualElement.Q<Button>("ButtonClient");
        m_clientDisconnect = m_uiDocument.rootVisualElement.Q<Button>("ButtonDisconnect");
    }
    private void Start()
    {
        m_hostButton.clicked += () => OnStartHost?.Invoke();
        m_clientButton.clicked += () => OnStartClient?.Invoke();
        m_clientDisconnect.clicked += () => OnDisconnectClient?.Invoke();
        EnableButtons();
    }

    public void DisableButtons()
    {
        m_hostButton.SetEnabled(false);
        m_clientButton.SetEnabled(false);
        m_clientDisconnect.SetEnabled(true);
    }

    public void EnableButtons()
    {
        m_hostButton.SetEnabled(true);
        m_clientButton.SetEnabled(true);
        m_clientDisconnect.SetEnabled(false);
    }
}
