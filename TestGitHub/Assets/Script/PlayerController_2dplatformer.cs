using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2dplatformer : MonoBehaviour
{
    [SerializeField] private float speed;
    private PlayerMovementControl PlayerMovementControl;
    public Animator animator;
   
    public BoxCollider2D boxcollider;
    private Camera cam = null;
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
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        //read movement value
        float movementInput_x = PlayerMovementControl.Land.Move.ReadValue<float>();
        float movementInput_y = PlayerMovementControl.Land.MoveUpDown.ReadValue<float>();

        //move the player
        Vector3 currentPosition = transform.position;
        Vector3 characterScale = transform.localScale;
        currentPosition.x += movementInput_x * speed * Time.deltaTime;
        if (movementInput_x > 0)
        {
            characterScale.x = (float)-2.68;
        }
        if (movementInput_x < 0)
        {
            characterScale.x = (float)2.68;
        }
        
        currentPosition.y += movementInput_y * 10 * Time.deltaTime;
        transform.position = currentPosition;
        transform.localScale = characterScale;

        animator.SetFloat("speed", Mathf.Abs(movementInput_x));

        

        if (PlayerMovementControl.Land.Attack.triggered)
        {
            animator.SetBool("Space_Clicked", true);
        }
        else
        {
            animator.SetBool("Space_Clicked", false);
        }


        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
    }
}
