#!/bin/bash
# Собирает SdiVariant10.app (рядом с папкой проекта), который запускается двойным щелчком
# и не требует установленного .NET. Нужен .NET SDK 10: brew install --cask dotnet-sdk
set -e
cd "$(dirname "$0")"

RID="osx-$(uname -m | sed 's/x86_64/x64/')"   # osx-arm64 или osx-x64
APP="../SdiVariant10.app"
OUT="bin/publish-$RID"

dotnet publish -c Release -r "$RID" --self-contained -o "$OUT"

rm -rf "$APP"
mkdir -p "$APP/Contents/MacOS"
cp -R "$OUT/" "$APP/Contents/MacOS/"
cat > "$APP/Contents/Info.plist" <<'EOF'
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>CFBundleName</key>
    <string>SDI Вариант 10</string>
    <key>CFBundleDisplayName</key>
    <string>SDI Вариант 10</string>
    <key>CFBundleIdentifier</key>
    <string>local.progeng.sdivariant10</string>
    <key>CFBundleVersion</key>
    <string>1.0</string>
    <key>CFBundleShortVersionString</key>
    <string>1.0</string>
    <key>CFBundlePackageType</key>
    <string>APPL</string>
    <key>CFBundleExecutable</key>
    <string>SdiVariant10Avalonia</string>
    <key>NSHighResolutionCapable</key>
    <true/>
</dict>
</plist>
EOF

# Локальная подпись без сертификата: без неё macOS на Apple Silicon не запустит программу.
codesign --force --deep --sign - "$APP"
echo "Готово: $(cd "$(dirname "$APP")" && pwd)/SdiVariant10.app"
