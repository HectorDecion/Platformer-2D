using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.123f;
    public Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
        transform.position = smoothedPosition;
    }
    // public Transform target;
    // public Vector3 offSet = new Vector3(0.2f, 0.0f, -10f);
    // public float dampingTime = 0.3f;
    // public Vector3 velocity = Vector3.zero;

    // Calculo Score
    //    public float startTime;
    //  public float journeyLenght;
    //public GameObject newTarget;

    // private void Awake()
    // {
    //     Application.targetFrameRate = 60;
    // }

    //  private void Start()
    //   {
    //      startTime = Time.time;
    //       journeyLenght = Vector3.Distance(this.transform.position, newTarget.transform.position);
    //   }
    //   private void Update()
    //   {

    //   }

    //    public void ResetCameraPosition()

    //  {

    //   }

    //   private void MoveCamera(bool smooth)
    //  {
    //      Vector3 destination = new Vector3(target.position.x - offSet.x, offSet.y, offSet.z);

    //     if (smooth)
    //     {
    //           this.transform.position = Vector3.SmoothDamp(this.transform.position, destination, ref velocity, dampingTime);
    //       }
    //       else
    //      {
    //          this.transform.position = destination;
    //       }
    //  }
}
