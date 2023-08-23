#!/usr/bin/env bash

echo "Cleaning existing code.."
rm -rf ./Unity/com.imgui.net/Runtime/ImGui.Net
rm -rf ./Unity/com.imgui.net/Runtime/ImGuizmo.NET
rm -rf ./Unity/com.imgui.net/Runtime/ImNodes.NET
rm -rf ./Unity/com.imgui.net/Runtime/ImPlot.NET

echo "Copying over code..."
cp -r ./src/ImGui.NET ./Unity/com.imgui.net/Runtime/ImGui.Net
cp -r ./src/ImGuizmo.NET ./Unity/com.imgui.net/Runtime/ImGuizmo.Net
cp -r ./src/ImNodes.NET ./Unity/com.imgui.net/Runtime/ImNodes.Net
cp -r ./src/ImPlot.NET ./Unity/com.imgui.net/Runtime/ImPlot.Net