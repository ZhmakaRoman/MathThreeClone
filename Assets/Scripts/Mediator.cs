using System;
using UnityEngine;

public class Mediator : MonoBehaviour
{
    [SerializeField] private ElementRemovalMechanism _elementRemovalMechanism;
    [SerializeField] private MatchBoardController _matchBoardController;

    private void Awake()
    {
        _elementRemovalMechanism.ElementDeletEvent +=
            () => StartCoroutine(_matchBoardController.FillBoardWithMatchesCheck());
        _matchBoardController.ElementReady +=
            () => StartCoroutine(_elementRemovalMechanism.DecreaseRowColumnAndFillBoard());
    }
}