using UnityEngine;

public class WallMove : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += MoveDownSmooth;
    }

    void OnDisable()
    {
        EventManager.OnClicked -= MoveDownSmooth;
    }

    public float moveDistance = 20f;

    public float moveSpeed = 5f;

    private bool isMoving = false;
    private Vector3 targetPosition;

    public void MoveDownSmooth()
    {
        if (isMoving) return;
        targetPosition = transform.position - new Vector3(0f, moveDistance, 0f);
        isMoving = true;
    }

    private void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                moveSpeed * Time.deltaTime
            );

            //if (transform.position == targetPosition)
            //{
            //    isMoving = false;
            //}
        }
    }
}
