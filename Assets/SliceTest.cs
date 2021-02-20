using EzySlice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceTest : MonoBehaviour
{
    public GameObject sourceGo;//切割的物体
    public GameObject slicerGo;//切片物体
    public Material sectionMat;//切面材质
 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SlicedHull hull = sourceGo.Slice(slicerGo.transform.position, slicerGo.transform.up);
            GameObject upper = hull.CreateUpperHull(sourceGo, sectionMat);
            GameObject lower = hull.CreateLowerHull(sourceGo, sectionMat);
            sourceGo.SetActive(false);
        }
    }

}
