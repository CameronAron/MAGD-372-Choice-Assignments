using UnityEngine;
using UnityEngine.InputSystem;

public class playerSpawn : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform p1Spawn, p2Spawn;
    private bool p1In = false;
    private bool p2In = false;

    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && !p1In)
        {
            var player1 = PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 0, controlScheme: "KeyboardOne", pairWithDevice: Keyboard.current, splitScreenIndex: 0);
            player1.transform.position = p1Spawn.position;
            p1In = true;
        }

        if(Input.GetKey(KeyCode.Alpha2) && !p2In)
        {
            var player2 = PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 1, controlScheme: "KeyboardTwo", pairWithDevice: Keyboard.current, splitScreenIndex: 1);
            player2.transform.position = p2Spawn.position;
            p2In = true;
        }
    }
}
