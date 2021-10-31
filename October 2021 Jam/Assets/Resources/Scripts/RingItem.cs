using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingItem : MagicItem
{
    public string possibleAbility;
    public int possiblePotency;

    public GemColor gemColor;
    public Vector2Int[] runes;

    public RingItem() {
        gemColor = (GemColor)Random.Range(0, 12);
        runes = new Vector2Int[Random.Range(0, 4)];

        // RUNE GENERATION
        if (runes.Length >= 1) {
            runes[0] = new Vector2Int(Random.Range(0, 6), Random.Range(0, 6));
        }
        if (runes.Length >= 2) {
            do {
                runes[1] = new Vector2Int(Random.Range(0, 6), Random.Range(0, 6));
            } while(runes[1].x == runes[0].x || runes[1].y == runes[0].y);
        }
        if (runes.Length == 3) {
            if (Random.Range(0, 2) == 0) {
                do {
                    runes[2] = new Vector2Int(runes[0].x, Random.Range(0, 6));
                } while(runes[2].y == runes[0].y || runes[2].y == runes[1].y);
            }
            else {
                do {
                    runes[2] = new Vector2Int(Random.Range(0, 6), runes[0].y);
                } while(runes[2].x == runes[0].x || runes[2].x == runes[1].x);
            }
        }
    }

    public override string ItemName() {
        return "Ring of " + Constants.GEM_COLOR_ABILITIES[(int)gemColor];
    }

    public override void CauseMishap() {

    }

    public override void CreateItemGO() {
        
    }
}
