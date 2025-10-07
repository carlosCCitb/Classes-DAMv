using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour, InputSystem_Actions.IPlayerActions
{
    [SerializeField] private GameObject bullet;
    private InputSystem_Actions inputActions;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Transform _shootPoint;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        inputActions = new InputSystem_Actions();
        inputActions.Player.SetCallbacks(this);
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        Instantiate(bullet, _shootPoint.position, Quaternion.identity);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        _rb.linearVelocity= context.ReadValue<Vector2>(); 
    }
}
