# GIRIGIRI

## 使用しているAssetStore産のAsset
* ProBuilder

## 共同作業を始めるには
1. 招待する側が setting=>Collaborators で共同作業したい人を招待する

以降は招待された側の操作

2. `git clone https://github.com/citrony/HelloGit`   
(`git checkout -b 新しく作るブランチ名`)   
(`git push -u origin 作ったブランチ名`)
3. ファイルを編集する
4. `git add .`
5. `git commit -m"コミットメッセージ"`
6. `git push origin カレントブランチ名`   
(GitHubでカレントブランチからmasterにプルリク投げる)

( )内はGitのブランチシステムを活用して運用する場合に行う操作。   
そうでない場合はmasterブランチを複数人で上書きしていく残念な運用になる。

## Gitの基本コマンド
* ローカルリポジトリ内の全ブランチを確認する   
`git branch -a`

* カレントブランチを変更する   
`git checkout 移動先のローカルブランチ名`

* 現在のadd、commit状況やカレントブランチを確認する   
`git status`

* addしていない編集したファイルの変更点を確認する   
`git diff`

その他詳しいGit操作は「Git操作」の資料を参照

