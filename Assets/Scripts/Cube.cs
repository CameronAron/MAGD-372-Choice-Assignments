using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public IEnumerator cubeMoveCoroutine(float moveTime)
    {
        Vector3 startingPos = transform.position;
        Vector3 finalPos = transform.position + (transform.right * 10f);

        float elapsedTime = 0;

        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / moveTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        elapsedTime = 0;

        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(finalPos, startingPos, (elapsedTime / moveTime));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        print(this.gameObject.name + " is done with coroutine movement");
    }

    public async Task cubeMoveAsync(float moveTime)
    {
        Vector3 startingPos = transform.position;
        Vector3 finalPos = transform.position + (transform.right * 10f);

        float elapsedTime = 0;

        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / moveTime));
            elapsedTime += Time.deltaTime;
            await Task.Yield();
        }

        elapsedTime = 0;

        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(finalPos, startingPos, (elapsedTime / moveTime));
            elapsedTime += Time.deltaTime;
            await Task.Yield();
        }

        print(this.gameObject.name + " is done with async movement");
    }

}
