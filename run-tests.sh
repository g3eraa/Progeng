#!/usr/bin/env bash
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

# Prefer an installed SDK; also support the temporary SDK used for this build.
if command -v dotnet >/dev/null 2>&1; then
    DOTNET_BIN="$(command -v dotnet)"
elif [[ -x /private/tmp/progeng-dotnet/dotnet ]]; then
    DOTNET_BIN=/private/tmp/progeng-dotnet/dotnet
else
    echo "Не найден .NET SDK. Установите SDK 8 или новее и среду выполнения .NET 8."
    exit 1
fi

export DOTNET_CLI_TELEMETRY_OPTOUT=1

echo "Автоматические тесты SDI — вариант 5"
"$DOTNET_BIN" test "$ROOT/SdiVariant5.Tests/SdiVariant5.Tests.csproj" \
    --configuration Release \
    --logger "console;verbosity=normal" \
    --logger "trx;LogFileName=tests.trx" \
    --results-directory "$ROOT/TestResults" \
    --nologo -m:1 -nr:false -p:UseSharedCompilation=false "$@"

echo "Отчёт сохранён: $ROOT/TestResults/tests.trx"
