using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    // public GameObject linePrefab;
    // Line activeLine;


    // void update(){
    //     if(Input.GetMouseButtonDown(0)){
    //         GameObject newLine = Instantiate(linePrefab);
    //         activeLine = newLine.GetComponent<Line>();
    //     }
    //     if(Input.GetMouseButtonUp(0)){
    //         activeLine = null;
    //     }

    //     if (activeLine !=null){
    //         Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //         activeLine.UpdateLine(mousePos);
    //     }
    // }
// public LineRenderer lineRenderer;
// public float lineWidth = 0.1f;

// private Camera mainCamera;
// private bool isDrawing = false;
// private List<Vector3> points = new List<Vector3>();

// void Start()
// {
//     mainCamera = Camera.main;
//     lineRenderer.startWidth = lineWidth;
//     lineRenderer.endWidth = lineWidth;
// }

// void Update()
// {
//     if (Input.GetMouseButtonDown(0))
//     {
//         StartDrawing();
//     }
//     else if (Input.GetMouseButtonUp(0))
//     {
//         StopDrawing();
//     }
//     else if (Input.GetMouseButton(0))
//     {
//         if (isDrawing)
//         {
//             Vector3 mousePos = GetMouseWorldPosition();
//             AddPoint(mousePos);
//         }
//         else
//         {
//             StopDrawing();
//         }
//     }
// }

// void StartDrawing()
// {
//     isDrawing = true;
//     points.Clear();
// }

// void StopDrawing()
// {
//     isDrawing = false;
// }

// void AddPoint(Vector3 point)
// {
//     points.Add(point);
//     lineRenderer.positionCount = points.Count;
//     lineRenderer.SetPositions(points.ToArray());
// }

// Vector3 GetMouseWorldPosition()
// {
//     Vector3 mousePos = Input.mousePosition;
//     mousePos.z = -mainCamera.transform.position.z;
//     return mainCamera.ScreenToWorldPoint(mousePos);
// }


    // public LineRenderer lineRenderer;
    // public float lineWidth = 0.1f;

    // private Camera mainCamera;
    // private bool isDrawing = false;

    // void Start()
    // {
    //     mainCamera = Camera.main;
    //     lineRenderer.startWidth = lineWidth;
    //     lineRenderer.endWidth = lineWidth;
    // }

    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         StartDrawing();
    //     }
    //     else if (Input.GetMouseButtonUp(0))
    //     {
    //         StopDrawing();
    //     }

    //     if (isDrawing)
    //     {
    //         Vector3 mousePos = GetMouseWorldPosition();
    //         AddPoint(mousePos);
    //     }
    // }

    // void StartDrawing()
    // {
    //     isDrawing = true;
    //     lineRenderer.positionCount = 0;
    // }

    // void StopDrawing()
    // {
    //     isDrawing = false;
    // }

    // void AddPoint(Vector3 point)
    // {
    //     int positionCount = lineRenderer.positionCount;
    //     lineRenderer.positionCount = positionCount + 1;
    //     lineRenderer.SetPosition(positionCount, point);
    // }

    // Vector3 GetMouseWorldPosition()
    // {
    //     Vector3 mousePos = Input.mousePosition;
    //     mousePos.z = -mainCamera.transform.position.z;
    //     return mainCamera.ScreenToWorldPoint(mousePos);
    // }
//    private LineRenderer line;
//     private Vector3 previousPosition;
//     public float minDistance = 0.1f;

//     private void Start()
//     {
//         line = GetComponent<LineRenderer>();
//         line.positionCount = 0;
//         previousPosition = transform.position;
//     }

//     private void Update()
//     {
//         if (Input.GetMouseButtonDown(0))
//         {
//             line.positionCount++;
//             line.SetPosition(line.positionCount - 1, GetCurrentMousePosition());
//         }
//         else if (Input.GetMouseButton(0))
//         {
//             Vector3 currentPosition = GetCurrentMousePosition();

//             if (Vector3.Distance(currentPosition, previousPosition) > minDistance)
//             {
//                 line.positionCount++;
//                 line.SetPosition(line.positionCount - 1, currentPosition);
//                 previousPosition = currentPosition;
//             }
//         }
//         else if (Input.GetMouseButtonDown(1))
//         {
//             ClearLine();
//         }
//     }

//     private Vector3 GetCurrentMousePosition()
//     {
//         Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//         currentPosition.z = 0f;
//         return currentPosition;
//     }

//     private void ClearLine()
//     {
//         line.positionCount = 0;
//     }
}
