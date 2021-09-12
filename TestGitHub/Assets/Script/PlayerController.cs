using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private PlayerMovementControl PlayerMovementControl;
    public Animator animator;

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
        currentPosition.y += movementInput_y * speed * Time.deltaTime;
        transform.position = currentPosition;
        transform.localScale = characterScale;

        animator.SetFloat("speed", Mathf.Abs(movementInput_x));

        if (PlayerMovementControl.Land.Attack.triggered)
        {
            animator.SetBool("Left_Click", true);
        }
        else
        {
            animator.SetBool("Left_Click", false);
        }
    }
}
