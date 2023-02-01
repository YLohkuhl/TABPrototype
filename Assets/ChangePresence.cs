using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static GlobalVariables;

public class ChangePresence : MonoBehaviour
{
    public Discord.ActivityManager activityManager;

    public static Scene currentScene;

    private string sceneName;

    public void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        activityManager = DiscordController.activityManager;
    }

    public void Update()
    {
        switch (sceneName)
        {
            case "Scene1":
                {
                    var scene1Activity = new Discord.Activity
                    {
                        State = "Scene 1",
                        Details = "Meeting the Button. Getting ready to play a game?",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(scene1Activity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Scene 1)!");
                        }
                    });
                    break;
                }
            case "OddFinding":
                {
                    var oddFindingActivity = new Discord.Activity
                    {
                        State = "Odd Finding",
                        Details = "Finding the button! Pretty easy.",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(oddFindingActivity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Odd Finding)!");
                        }
                    });
                    break;
                }
            case "Scene2":
                {
                    var scene2Activity = new Discord.Activity
                    {
                        State = "Scene 2",
                        Details = "Beat the mini game. Time for the next one.",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(scene2Activity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Scene 2)!");
                        }
                    });
                    break;
                }
            case "Clicking50":
                {
                    var clicking50Activity = new Discord.Activity
                    {
                        State = "Clicking 50",
                        Details = "Click, Click, Click! (50 Times)",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(clicking50Activity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Clicking 50)!");
                        }
                    });
                    break;
                }
            case "Scene3":
                {
                    var scene3Activity = new Discord.Activity
                    {
                        State = "Scene 3",
                        Details = "Face Reveal? Interesting..",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(scene3Activity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Scene 3)!");
                        }
                    });
                    break;
                }
            case "Clicking150":
                {
                    var clicking150Activity = new Discord.Activity
                    {
                        State = "Scene 3",
                        Details = "Click.. Click.. Click..! (150 Times)",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(clicking150Activity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Clicking 150)!");
                        }
                    });
                    break;
                }
            case "OddFinding2":
                {
                    var oddFinding2Activity = new Discord.Activity
                    {
                        State = "Odd Finding 2",
                        Details = "Button is getting agitated.. mind spotting it out?",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(oddFinding2Activity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Odd Finding 2)!");
                        }
                    });
                    break;
                }
            case "Scene4":
                {
                    var scene4Activity = new Discord.Activity
                    {
                        State = "Scene 4",
                        Details = "Tophat Reveal? Interesting..",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(scene4Activity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Scene 4)!");
                        }
                    });
                    break;
                }
            case "Clicking300":
                {
                    var clicking300Activity = new Discord.Activity
                    {
                        State = "Clicking 300",
                        Details = "Click. Click. Click. (300 Times)",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(clicking300Activity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Clicking 300)!");
                        }
                    });
                    break;
                }
            case "SceneBA":
                {
                    var sceneBAActivity = new Discord.Activity
                    {
                        State = "Scene B.A",
                        Details = "B.A has been revealed.. will this come back?",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(sceneBAActivity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Scene BA)!");
                        }
                    });
                    break;
                }
            case "SceneEnd":
                {
                    var sceneEndActivity = new Discord.Activity
                    {
                        State = "Scene End",
                        Details = "Seems its came to end after all, or has it?",
                        Assets =
                        {
                            LargeImage = "icon",
                            LargeText = $"TAB ({versionNumber})"
                        }
                    };
                    activityManager.UpdateActivity(sceneEndActivity, (res) =>
                    {
                        if (res == Discord.Result.Ok)
                        {
                            Debug.Log("Discord Presence Changed (Scene End)!");
                        }
                    });
                    break;
                }
        }
    }
}
