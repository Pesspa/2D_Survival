using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum EnvironmentType
{
    chest,
    healer
}
public class InteractionWithEnvironment : MonoBehaviour
{
    public GameObject InteractivePanel;
    public enum EnvironmentType
    {
        chest,
        healer,
        notActive
    }

    public EnvironmentType environment;
    private void OnTriggerStay2D(Collider2D other)
    {
       if(environment == EnvironmentType.chest)
        {
            InteractivePanel.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {

            }
        } 
    }
    void Update()
    {
        
    }
    public void OpenChest()
    {

    }
}
