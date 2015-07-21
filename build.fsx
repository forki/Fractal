#r @"packages/FAKE/tools/FakeLib.dll"

open Fake
open Fake.Git
open Fake.AssemblyInfoFile
open Fake.ReleaseNotesHelper
open System
open System.IO

let project = "Fractal"
let fsProjs =  !! "src/**/*.fsproj"

Environment.CurrentDirectory <- __SOURCE_DIRECTORY__
let release = LoadReleaseNotes "RELEASE_NOTES.md"

let genFSAssemblyInfo (projectPath) =
    let projectName = Path.GetFileNameWithoutExtension(projectPath)
    let basePath = "src/" + projectName
    let fileName = basePath + "/AssemblyInfo.fs"
    CreateFSharpAssemblyInfo fileName
      [ Attribute.Title (projectName)
        Attribute.Product project
        Attribute.Version release.AssemblyVersion
        Attribute.FileVersion release.AssemblyVersion ]

Target "AssemblyInfo" (fun _ ->
  fsProjs |> Seq.iter genFSAssemblyInfo
)

Target "Build" (fun _ ->
    fsProjs
    |> MSBuildRelease "" "Rebuild"
    |> ignore
)

Target "Publish" (fun _ ->
    StageAll ""
    Git.Commit.Commit "" (sprintf "Version %s" release.AssemblyVersion )
    Git.Branches.push ""
)

"AssemblyInfo"
  ==> "Build"
  ==> "Publish"

RunTargetOrDefault "Build"
