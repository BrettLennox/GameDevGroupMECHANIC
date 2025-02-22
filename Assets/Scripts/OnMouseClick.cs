using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseClick : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    private Transform spawnPos;

    public Camera MainCamera { get => _mainCamera; private set => _mainCamera = value; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CubeHandler.SharedInstance.UseCube(CalculateMousePosition());
        }
    }

    private Vector3 CalculateMousePosition()
    {
        Vector3 mouseWorldPosition = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        Debug.Log(mouseWorldPosition);
        return mouseWorldPosition;
    }
}
