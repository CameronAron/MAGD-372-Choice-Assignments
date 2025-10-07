using UnityEngine;
using UnityEngine.InputSystem;

public class playerSpawn : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform p1Spawn, p2Spawn;

    void Start()
    {
        var player1 = PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 0, controlScheme: "KeyboardOne", pairWithDevice: Keyboard.current, splitScreenIndex: 0);
        var player2 = PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 1, controlScheme: "KeyboardTwo", pairWithDevice: Keyboard.current, splitScreenIndex: 1);

        player1.transform.position = p1Spawn.position;
        player2.transform.position = p2Spawn.position;
    }
}
