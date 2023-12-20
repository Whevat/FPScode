using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BasicTextUI : MonoBehaviour
{
    [SerializeField] InputManager iG;
    [SerializeField] PlayerMotor pM;
    [SerializeField] TextMeshProUGUI mouseStatus;
    [SerializeField] TextMeshProUGUI crouchStatus;
    [SerializeField] TextMeshProUGUI sprintStatus;

    void Update()
    {
        mouseStatus.text = "Mouse Status: " + iG.mouseLock;
        crouchStatus.text = "Crouch Status: " + pM.crouching;
        sprintStatus.text = "Sprint Status: " + pM.sprinting;
    }
}
