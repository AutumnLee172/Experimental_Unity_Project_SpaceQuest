using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller_Maze : MonoBehaviour
{
    [SerializeField] private float speed;
    private PlayerMovementControl PlayerMovementControl;
    public BoxCollider2D boxcollider;
    private float lockPos = 0;
    private void Awake()
    {
        PlayerMovementControl = new PlayerMovementControl();
    }

    private void OnEnable()
    {
        PlayerMovementControl.Enable();
    }

    private void OnDisable()
    {
        PlayerMovementControl.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //read movement value
        float movementInput_x = PlayerMovementControl.Land.Move.ReadValue<float>();
        float movementInput_y = PlayerMovementControl.Land.MoveUpDown.ReadValue<float>();

        //move the player
        Vector3 currentPosition = transform.position;
       
        currentPosition.x += movementInput_x * speed * Time.deltaTime;
       
        currentPosition.y += movementInput_y * speed * Time.deltaTime;
        transform.position = currentPosition;



        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
    }
}
