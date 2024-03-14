using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTarget : MonoBehaviour
{
    public List<Collider> skillTargetList;
    // Start is called before the first frame update
    void Start()
    {
        skillTargetList = new List<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        skillTargetList.Add(other);
    }

    private void OnTriggerExit(Collider other)
    {
        skillTargetList.Remove(other);
    }
}
