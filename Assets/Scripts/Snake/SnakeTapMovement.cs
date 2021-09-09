using UnityEngine;

public class SnakeTapMovement : MonoBehaviour
{
    
    [SerializeField] private float _speedModifier = 0.01f;
    [SerializeField] private float _clampPositionX = 2.75f;

    private void OnEnable()
    {
        PlayerTapInput.OnTapedToScreen += MoveToTapPosition;
    }

    private void OnDisable()
    {
        PlayerTapInput.OnTapedToScreen -= MoveToTapPosition;
    }

    private void MoveToTapPosition(Vector3 direction)
    {
        direction *= _speedModifier;
        transform.position += direction;
        ClampLocalPosition();
    }

    private void ClampLocalPosition()
    {
        if(Time.timeScale != 0)
        {
            transform.localPosition = new Vector3(
            Mathf.Clamp(transform.localPosition.x, -_clampPositionX, _clampPositionX),
            transform.localPosition.y,
            transform.localPosition.z);
        }
    }
}
