using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myUtils;

public class PlayerController : MonoBehaviour
{

    [Header("References")]
    private Rigidbody rb;
    [SerializeField] Camera mainCamera;
    public LayerMask mouseHitLayer;


    [Header("Properties")]
    public float moveSpeed;
    public float rotationSpeed;



    private Vector3 mousePosition;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        print(myUtils.Utils.name);
    }

    // Update is called once per frame
    void Update()
    {
        TrackMousePosition();

        ControlMovement();
    }

    void TrackMousePosition()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, mouseHitLayer))
        {
            Vector3 lookPos = hit.point;
            lookPos.y = transform.position.y;
            transform.LookAt(lookPos);
        }

    }

    void ControlMovement()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // transform.Translate(transform.forward * moveInput.y * moveSpeed * Time.deltaTime);
        // transform.Translate(transform.right * moveInput.x * moveSpeed * Time.deltaTime);

        transform.Translate(new Vector3(moveInput.x, 0, moveInput.y) * moveSpeed * Time.deltaTime, Space.World);


    }

}
