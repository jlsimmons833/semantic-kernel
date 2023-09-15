import os
import config
import sys

import semantic_kernel as sk
from semantic_kernel.core_skills import TimeSkill

from semantic_kernel.connectors.ai.open_ai import OpenAIChatCompletion

kernel = sk.Kernel(log=sk.NullLogger())
kernel.add_chat_service(
    "chat_completion",
    OpenAIChatCompletion(
        config.get("OPEN_AI__CHAT_COMPLETION_MODEL_ID", None),
        config.get("OPEN_AI__API_KEY", None),
        config.get("OPEN_AI__ORG_ID", None),
    ),
)

# time = kernel.import_skill(TimeSkill())
# result = kernel.run_async(time["today"])

# print(result)