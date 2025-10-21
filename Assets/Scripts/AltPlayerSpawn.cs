using UnityEngine;
using UnityEngine.InputSystem;

public class AltPlayerSpawn : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform p1Spawn, p2Spawn;
    private bool p2In = false;

    void Start()
    {
        var player1 = PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 0, controlScheme: "KeyboardOne", pairWithDevice: Keyboard.current, splitScreenIndex: 0);
        player1.transform.position = p1Spawn.position;
    }

    void OnEnable()
    {
        EventManager.OnPressed += spawnP2;
    }

    void OnDisable()
    {
        EventManager.OnPressed -= spawnP2;
    }

    void spawnP2()
    {
        if (!p2In)
        {
            var player2 = PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 1, controlScheme: "KeyboardTwo", pairWithDevice: Keyboard.current, splitScreenIndex: 1);
            player2.transform.position = p2Spawn.position;
            p2In = true;
        }
    }
}
