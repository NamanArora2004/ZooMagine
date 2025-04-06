using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class prefabCreator : MonoBehaviour
{
    [SerializeField] private GameObject d;
    [SerializeField] private Vector3 prefabOffset;
    private GameObject dragon;
    private ARTrackedImageManager a;
    private void OnEnable()
    {
        a = gameObject.GetComponent<ARTrackedImageManager>();
        a.trackedImagesChanged += OnImageChanged;
    }
    private void OnImageChanged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach (ARTrackedImage image in obj.added)
        {
            dragon = Instantiate(d, image.transform);
            dragon.transform.position += prefabOffset;
        }
    }
}