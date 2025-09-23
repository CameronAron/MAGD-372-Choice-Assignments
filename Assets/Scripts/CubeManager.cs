using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] Cube[] _cubes;
    public float movementTime;

    public void runCoroutineSimultaneous()
    {
        for (var i = 0; i < _cubes.Length; i++)
        {
            StartCoroutine(_cubes[i].cubeMoveCoroutine(movementTime/2));
        }
    }

    public void runAsyncSimultaneous()
    {
        for (var i = 0; i < _cubes.Length; i++)
        {
            _cubes[i].cubeMoveAsync(movementTime/2);
        }
    }

    public void runCoroutineSequential()
    {
        StartCoroutine(runCoroutineSequentialpt2());
    }

    IEnumerator runCoroutineSequentialpt2()
    {
        yield return StartCoroutine(_cubes[0].cubeMoveCoroutine(movementTime / 2));
        yield return StartCoroutine(_cubes[1].cubeMoveCoroutine(movementTime / 2));
        yield return StartCoroutine(_cubes[2].cubeMoveCoroutine(movementTime / 2));
    }

    public async void runAsyncSequential()
    {
        for (var i = 0; i < _cubes.Length; i++)
        {
            await _cubes[i].cubeMoveAsync(movementTime / 2);
        }
    }

}
