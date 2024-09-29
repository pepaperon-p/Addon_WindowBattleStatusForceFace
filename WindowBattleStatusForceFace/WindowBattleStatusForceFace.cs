/*:
 * @addondesc Change the status display in battle scenes to face-up
 * @author Author
 * @help This addon is a dummy for patch management.
 * Please apply the patch as follows:
 * ex.)
 * $ copy WindowBattleStatusForceFace.patch [project]\Assets\RPGMaker\Codebase
 * $ cd [project]\Assets\RPGMaker\Codebase
 * $ git apply WindowBattleStatusForceFace.patch
 * 
 * @command doWindowBattleStatusForceFace
 */

/*:ja
 * @addondesc 戦闘シーンのステータス表示をフェイスアップにします
 * @author Author
 * @help このアドオンはパッチ管理用のダミーです。
 * 以下等の様にパッチを適用してください。
 * ex.)
 * $ copy WindowBattleStatusForceFace.patch [プロジェクト]\Assets\RPGMaker\Codebase
 * $ cd [プロジェクト]\Assets\RPGMaker\Codebase
 * $ git apply WindowBattleStatusForceFace.patch
 * 
 * @command doWindowBattleStatusForceFace
 */

using RPGMaker.Codebase.CoreSystem.Knowledge.DataModel.Runtime;
using RPGMaker.Codebase.Runtime.Addon;
using RPGMaker.Codebase.Runtime.Common;
using UnityEngine;

namespace RPGMaker.Codebase.Addon
{
  public class WindowBattleStatusForceFace
  {
    public void doWindowBattleStatusForceFace(){}
  }
}
