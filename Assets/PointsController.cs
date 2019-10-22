using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    public GameObject[] points;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var point in points) {
            point.SetActive(false);
        }
        points[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (points[count].GetComponent<PointChecker>().Passing) {
            points[count].SetActive(false);
            if (count < points.Length - 1) {
                points[++count].SetActive(true);
            }
        }
    }
}
